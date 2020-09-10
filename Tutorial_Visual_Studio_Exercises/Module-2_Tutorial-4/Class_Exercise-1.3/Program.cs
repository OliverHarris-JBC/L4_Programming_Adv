/* SUMMARY: 
 * This exercise involves a Class using 2 Interfaces 
*/
/* STEP 1:
 * Aim: Extend the Car class to support a clutch() Method
 * 
 * Copy the code for the Car class that you used in the last exercise. We are going add another Interface
 * to the Car class.
 * First add a method called changeClutchState(bool) to your Car class, this will take a true/false parameter that can be used
 * to determine if the clutch is to be engaged/disengaged and you should produce the following Console output
 * "Clutch is now <engaged/disengaged>" in this Method to display its state. 
 * Prove this is working before going onto the next step
*/
/* STEP 2: 
 * Aim: To allow the Car changeClutchState(bool) method to be accessible via an additional Interface on the Car class
 * 
 * Now add a new Interface to your Car class which contains the method changeClutchState(bool)
 * Change your Program code to use both the clutch and brake Interfaces and verify that the output 
 * is as you would expect when invoking these methods via their respective Interfaces
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Exercise_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
