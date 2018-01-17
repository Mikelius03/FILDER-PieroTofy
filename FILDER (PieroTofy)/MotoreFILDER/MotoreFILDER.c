#include "MyFilder.h"

void MotoreFILDER( SettFILDER* settBase, DIRDATA* h )
{
    intptr_t hFind; // return _findfirst
    h->levelSubFolder++;
    char* myFILE = NULL;

    my_getcwd( &myFILE );

    if( h->levelSubFolder == 0 )
        printf( "\t\t\tCartella da setacciare \n\t\t\t[%s]\n\n", myFILE );
    else
        printf( "%s\n", myFILE );

    free( myFILE );


    hFind = _findfirst( "*.*", &h->FindData );
    h->fOk = ( hFind != -1L );

    while( h->fOk ) {
        h->fIsDir = IsChildDir( &h->FindData );

        if( !h->fIsDir || ( !settBase->recSearch && IsChildDir( &h->FindData ) ) ) {

            if( (h->FindData.name[0]) != '.' ) {
                if( h->fIsDir ) {
                    printf( "--> %s\n", h->FindData.name );
                } else {
                    printf( "          -> %s\n", h->FindData.name );
                }
            }
        }

        h->fOk = _findnext( hFind, &h->FindData ) == 0 ? TRUE : FALSE;
    }

    if( hFind != -1L )        _findclose( hFind );

        if( settBase->recSearch) {
            hFind = FindFirstChildDir( "*.*", &h->FindData );
            h->fOk = ( hFind != -1L );

            while( h->fOk ) {
                if( my_chdir( h->FindData.name ) == 0 ) {
                    MotoreFILDER( settBase,h );
                    my_chdir( ".." );
                }
                h->fOk = FindNextChildDir((long)hFind, &h->FindData );
            }

            if( hFind != -1L )            _findclose( hFind );
        }
        
    h->levelSubFolder--;
}