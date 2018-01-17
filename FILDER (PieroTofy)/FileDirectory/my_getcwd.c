#include "FileDirectory.h"

MYRETURN my_getcwd( char **path )
{
    AZZ_ERROR;
    if( path == NULL )    return MYER_PPTN( 1 );

#if defined (__clang__) || defined(_MSC_VER)
    if( ( ( *path ) = _getcwd( NULL, 0 ) ) != NULL )
#else
    if( ( ( *path ) = getcwd( NULL, 0 ) ) != NULL )
#endif // defined

        return SUCCESS;
    else
        return INSUCCESS;
}
