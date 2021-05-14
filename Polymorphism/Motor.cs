/*************************************************************
 * Illustrate Polymorphic Methods.                           *
 *                                                           *
 * A class that derives from the abstract base class         *
 *                                                           *
 *                                                           *
 * Bill Nicholson                                            *
 *************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Motor: Device
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID">The Identifier of the Device</param>
        public Motor(String ID) : base(ID)
        {            
        }

        /// <summary>
        /// Start the Motor
        /// </summary>
        public override void Start()
        {
            Console.WriteLine("Starting Motor " + ID);
        }
        /// <summary>
        /// Stop the Motor
        /// </summary>
        public override void Stop()
        {
            Console.WriteLine("Stopping Motor " + ID);
        }
    }
}
