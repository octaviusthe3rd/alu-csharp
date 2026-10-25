using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// The zombie's health.
        /// </summary>
        private int health;

        public Zombie()
        {
            health = 0;
        }


        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }


        public int GetHealth()
        {
            return health;
        }
    }
}