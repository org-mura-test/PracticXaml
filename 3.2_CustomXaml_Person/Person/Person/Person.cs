
namespace CustomXamlPerson
{
    public class Person
    {

        public DateTime Birthday { get; private set; }

        public Person()
        {
            this.Birthday = DateTime.Now;
        }

        // ���O�Ƌ�����ǉ�
        public string FullName { get; set; }
        public int Salary { get; set; }

    }

}