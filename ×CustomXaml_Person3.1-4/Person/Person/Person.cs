
namespace CustomXamlPerson
{
    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

    }

}