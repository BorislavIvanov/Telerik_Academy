namespace ComputersUI.ConsoleClient.SystemComponents
{
    public class Battery
    {
        public Battery()
        {
            this.Percentage = 50;
        }

        public int Percentage { get; private set; }

        public void Charge(int chargePercent)
        {
            this.Percentage += chargePercent;

            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }
            else if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }
    }
}
