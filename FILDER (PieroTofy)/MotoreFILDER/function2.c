/**********************************************************************************//*
 * \license GNU LGPL 3.0
 * \author Michele Cannavo'
 * \date 2018-01-18

Copyright (c) 2017- 2018, Michele Cannavo'
All rights reserved.

This file is part of FILDER.

    FILDER is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FILDER is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FILDER.  If not, see <http://www.gnu.org/licenses/>.
 ************************************************************************************/
#include "MyFilder.h"
BOOL IsChildDir (struct _finddata_t *lpFindData)
{
    BOOL bRet = (lpFindData->attrib & _A_SUBDIR) &&
                (lpFindData->name[0] != '.');
    
    return bRet;
}

BOOL FindNextChildDir (long hFindFile, struct _finddata_t *lpFindData)
{
    BOOL fFound = FALSE;

    int nFind;

    do
    {
        nFind = _findnext(hFindFile, lpFindData);
        if ( nFind == 0 )
            fFound = TRUE;
        else
            fFound = FALSE;
    } while ( fFound && !IsChildDir(lpFindData) );
    
    return(fFound);
}

long FindFirstChildDir (char * szPath, struct _finddata_t *lpFindData)
{
    BOOL fFound;

    long hFindFile = _findfirst(szPath, lpFindData);

    if (hFindFile != -1L)
    {
        fFound = IsChildDir(lpFindData);

        if (!fFound)
            fFound = FindNextChildDir(hFindFile, lpFindData);

        if (!fFound)
        {
            _findclose(hFindFile);
            hFindFile = -1L;
        }
    }
    return(hFindFile);
}