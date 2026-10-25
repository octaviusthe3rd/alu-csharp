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

        /// <summary>
        /// The zombie's name.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Gets or sets the zombie's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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