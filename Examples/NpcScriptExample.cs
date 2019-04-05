using LegacyConquer.Api;

namespace NpcTemplate
{
    public class MyNpcScript : INpcScript
    {
        const uint Vanilla = 1002020;
        const uint Meteor = 1088001;

        public override void Start()
        {

            Dialog.Avatar = 1;
            Dialog.Text =
                $"Welcome {Client.Name}, Would you like to convert 5 Vanillas to a Meteor? OR Would you like to exchange 5 vanillas for the same experience as an ExpBall?";
            Dialog.Option(ConvertToMeteor, "Gimmie a Meteor.");
            Dialog.Option(AwardExpBall, "Gimmie Exp!");
            Dialog.PassingBy();
        }

        public bool RemoveVanillas(uint vanillaAmount)
        {
            var amount = Client.Inventory.CountItems(Vanilla, true);
            if (!Client.Inventory.IsFull)
            {
                if (amount >= vanillaAmount)
                {
                    Client.Inventory.RemoveItems(Vanilla, vanillaAmount);
                    return true;

                }
                else
                {
                    Dialog.Text = "You do not have enough Vanilla in your inventory. Get some and come back :)";
                    Dialog.ISee();

                }
            }
            else
            {
                Dialog.Text = "Your inventory is full, free some space before continuing.";
                Dialog.ISee();
            }

            return false;
        }

        public void AwardExpBall()
        {
            if (RemoveVanillas(5))
            {
                Dialog.Text = "Thankyou for your support! Here is your Exp.";
                Dialog.PassingBy();
                Client.Exp.AwardExpBall(1);
            }
        }

        public void ConvertToMeteor()
        {
            if (RemoveVanillas(5))
            {
                Client.Inventory.AddItem(Client.CreateNewItem(Meteor, 0));
                Dialog.Text = "Thankyou for your support! Here is your Meteor.";
                Dialog.PassingBy();
            }
        }
    }
}