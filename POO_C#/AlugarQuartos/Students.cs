namespace AlugarQuartos
{
    public class Students
    {
        public string Name, Email;        

    public Students (string name, string email){
        Name = name;
        Email = email;
    }
        public override string ToString() {
            return Name + " , " + Email;
            
        }
    }
}