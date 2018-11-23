namespace Opgave_Variabler_struct_enum
{
    public struct Person
    {
        public int Id;
        public string Navn;
        public Køn Køn;

        public Person(int id, string navn, Køn køn)
        {
            this.Id = id;
            this.Navn = navn;
            this.Køn = køn;
        }
    }
    
}
