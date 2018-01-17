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