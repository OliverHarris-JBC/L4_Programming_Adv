/* SUMMARY:
 * To implement a Class Interface
*/
/* STEP 1:
 * Create a Class called Car and let it have a Method called void applyBrake(int force) when this Method
 * is called it will output "Braking with force <value>!"
 * Create an instance of Car and check that you get the correct output on the console you select Method
 * brake(<value>);
*/
/* STEP 2:
 * Introduce an Interface (ICar) which includes the method void applyBrake()
 
 * Create a reference to the Car Interface and cast this to an instance of the Car. You can now call the
 * applyBrake() method via the ICar interface.
 * 
 * You should verify that the method in the Class gets called via the interface and displays the required output.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Exercise_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
