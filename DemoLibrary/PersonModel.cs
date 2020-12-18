using PostSharp.Patterns.Model;

namespace DemoLibrary
{
    /// <summary>
    ///     Record for a person.
    /// </summary>
    [NotifyPropertyChanged]
    public class PersonModel
    {
        /// <summary>
        ///     Gets or sets this person's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///     Gets this person's full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        ///     ID of the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets this person last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => FullName;
    }
}