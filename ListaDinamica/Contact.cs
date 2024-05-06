namespace ListaDinamica
{
    internal class Contact
    {
        string Name;
        string Phone;
        Contact Next;

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
            Next = null;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetNext(Contact nextContact) 
        {
            Next = nextContact;
        }
        public Contact GetNext()
        {
            return Next;
        }
    }
}
