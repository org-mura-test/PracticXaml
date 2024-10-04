
namespace CustomXamlPerson
{
    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

        // –¼‘O‚Æ‹‹—¿‚ð’Ç‰Á
        public string FullName { get; set; }
        public int Salary { get; set; }

    }

}