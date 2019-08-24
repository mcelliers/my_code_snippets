/************************************************************************************************\
*                   Quantum Design and Engineering (PTY) Ltd
*
*   Application Name :
*   Updated          :
*   Notes            :
*
\************************************************************************************************/

#include <stdio.h>
void loop(void);     //loop prototype - usually done in header
vois setup(void);    //setup prototype - usually done in header

///     Application start 
///
///
void main()
{
    setup();   //Initialize
    for(;;)
    {
        loop();  //loop forever
    }

}

///     Setup /Initialise Function
///
///
void setup()
{
    //Initialisation code here

}

///     Main Loop Function
///
///
void main()
{
    //application code here - continuous loop

}
