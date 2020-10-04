namespace Prototype.Data
{
    public class Employee : Person
    {

        public override bool IsEmployee
        {
            get
            {
                return true;
            }
        }
    }
}