#include "MyFilder.h"


int main( int argc, char* argv[] )
{

    SettFILDER* settaggi=calloc(1,sizeof(SettFILDER*));


    if( argc >= 3  )
        /*3= Nome Eseguibile, Percorso cartella, Pattern */
        settaggi = inizializeCommandLine( argv);
    else
        settaggi = inizializeConsole();

    if( settaggi )
        searchF( settaggi );
    else
        printf( "\n\n\t\t problemi\n\n" );

    getchar();

    return 0;

}
