namespace Bank.Entities
{
    public class Bank_Account
    {
        public int BankNumber { get; set; }
        public int BranchNumber { get; set; }
        public int Id { get; set; }
        public string OwnersName { get; set; }
        public int OwnersId { get; set; }

        public Bank_Account(int bankNumber, int branchNumber, int id, string ownersName, int ownersId)
        {
            BankNumber = bankNumber;
            BranchNumber = branchNumber;
            Id = id;
            OwnersName = ownersName;
            OwnersId = ownersId;
        }

       
    }
}
