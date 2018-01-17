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
