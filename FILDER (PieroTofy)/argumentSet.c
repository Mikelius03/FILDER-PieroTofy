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

SettFILDER* inizializeCommandLine( char* argv[] )
{
    SettFILDER* settaggi = (SettFILDER*)malloc( sizeof( SettFILDER ) );
    if( settaggi == NULL )
        return NULL;

    strcpy( settaggi->dirWork, argv[1] );
    strcpy( settaggi->patternFILDER, argv[2] );
    settaggi->recSearch = TRUE;
    return settaggi;
}

/* Poi in 4° momento li setto da console, ora mi secco XD*/
SettFILDER* inizializeConsole()
{
    SettFILDER* settaggi = (SettFILDER*)malloc( sizeof( SettFILDER ) );
    if( settaggi == NULL )
        return NULL;

    strcpy( settaggi->dirWork, "./" );
    strcpy( settaggi->patternFILDER, "*.*" );
    settaggi->recSearch = FALSE;
    return settaggi;
}
