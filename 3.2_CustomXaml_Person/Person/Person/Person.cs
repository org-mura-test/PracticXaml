
namespace CustomXamlPerson
{
    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

        // 名前と給料を追加
        public string FullName { get; set; }
        public int Salary { get; set; }

    }

}