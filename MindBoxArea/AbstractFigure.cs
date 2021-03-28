
namespace MindBoxArea
{
    /// <summary>
    /// This abstract class can be used to create whatever figures you want.
    /// </summary>
    public abstract class AbstractFigure
    {
        public string Name { get; set; }

        /// <summary>
        /// Creates a figure with the specified name.
        /// </summary>
        /// <param name="name">Figure's name.</param>
        public AbstractFigure(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Returns the area value of the figure.
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

    }
}
