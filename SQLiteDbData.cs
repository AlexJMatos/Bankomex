using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class Client
    {
        public int Id { get; }
        public string UserName { get; }
        public string PIN { get; }
        public string FirstName { get; }
        public string LastName { get; }


        public Client(int id, string userName, string pin, string firstName, string lastName)
        {
            Id = id;
            UserName = userName;
            PIN = pin;
            FirstName = firstName;
            LastName = lastName;
        }

        public Client(string userName, string pin, string firstName, string lastName)
        {
            UserName = userName;
            PIN = pin;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Account
    {
        public int Id { get; }
        public int ClientId { get; }
        public int AccountType { get; }
        public double Balance { get; set; }

        public Account(int id, int clientId, int accountType, double balance)
        {
            Id = id;
            ClientId = clientId;
            AccountType = accountType;
            Balance = balance;
        }

        public Account(int clientId, int accountType, double balance)
        {
            ClientId = clientId;
            AccountType = accountType;
            Balance = balance;
        }
    }

    public class AccountType
    {
        public int Id { get; }
        public string Name { get; }
        public double MonthlyFee { get; }
        public double AnualFee { get; }
        public bool IsCredit { get; }
        public bool IsLimited { get; }
        public double OverDraftFee { get; }
        public double MaxCredit { get; }
        public double InteresPct { get; }

        public AccountType(int id, string name, double monthlyFee, double anualFee,
            bool isCredit, bool isLimited, double overDraftFee, double maxCredit,
            double interesPct)
        {
            Id = id;
            Name = name;
            MonthlyFee = monthlyFee;
            AnualFee = anualFee;
            IsCredit = isCredit;
            IsLimited = isLimited;
            OverDraftFee = overDraftFee;
            MaxCredit = maxCredit;
            InteresPct = interesPct;
            InteresPct = interesPct;
        }
    }

    public class ClientAccount
    {
        private int clientId;
        private string lastName;
        private string firstName;
        private int accountId;
        private string accountTypeName;
        private double balance;

        public int ClientId { get => clientId; set => clientId = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        public string AccountTypeName { get => accountTypeName; set => accountTypeName = value; }
        public double Balance { get => balance; set => balance = value; }

        public ClientAccount(int clientId, string lastName, string firstName, int accountId, string accountTypeName, double balance)
        {
            ClientId = clientId;
            LastName = lastName;
            FirstName = firstName;
            AccountId = accountId;
            AccountTypeName = accountTypeName;
            Balance = balance;
        }
    }

    public partial class SQLiteConn
    {
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT * FROM clients"))
            {
                while (rs.NextRecord())
                {
                    clients.Add(new Client(rs.GetInt32("Id"),
                                rs.GetString("UserName"),
                                rs.GetString("PIN"),
                                rs.GetString("FirstName"),
                                rs.GetString("LastName")));
                }
            }
            return clients;
        }

        public Client GetClientByID(int id)
        {
            Client client = null;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM clients WHERE Id = {id}"))
            {
                while (rs.NextRecord())
                {
                    client = new Client(rs.GetInt32("Id"),
                                rs.GetString("UserName"),
                                rs.GetString("PIN"),
                                rs.GetString("FirstName"),
                                rs.GetString("LastName"));
                }
            }
            return client;
        }

        public bool ClientUsernameUnique(String username)
        {
            foreach (Client client in GetClients())
            {
                if (client.UserName.ToLower().Equals(username))
                {
                    return false;
                }
            }
            return true;
        }

        public void AddClient(Client client)
        {
            ExecuteNonQuery("INSERT INTO clients (Id, UserName, PIN, FirstName, LastName)" +
                $"VALUES (null, '{client.UserName}', '{client.PIN}', '{client.FirstName}', '{client.LastName}')");
        }

        public List<Client> GetClientsByFirstNameOrLastName(String search)
        {
            List<Client> clients = new List<Client>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM clients WHERE LOWER(FirstName) LIKE '%{search.ToLower()}%' OR LOWER(LastName) LIKE '%{search.ToLower()}%'"))
            {
                while (rs.NextRecord())
                {
                    clients.Add(new Client(rs.GetInt32("Id"),
                                rs.GetString("UserName"),
                                rs.GetString("PIN"),
                                rs.GetString("FirstName"),
                                rs.GetString("LastName")));
                }
            }
            return clients;
        }

        public List<int> getClientsIds()
        {
            List<int> clientsIds = new List<int>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT Id FROM clients"))
            {
                while (rs.NextRecord())
                {
                    clientsIds.Add(rs.GetInt32("Id"));
                }
            }
            return clientsIds;
        }

        public List<string> getAccountTypes()
        {
            List<string> accountTypes = new List<string>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT Name FROM account_types"))
            {
                while (rs.NextRecord())
                {
                    accountTypes.Add(rs.GetString("Name"));
                }
            }
            return accountTypes;
        }

        public int getAccountTypeIdByName(string name)
        {
            int accountTypeId = -1;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT Id FROM account_types WHERE Name = '{name}'"))
            {
                while (rs.NextRecord())
                {
                    accountTypeId = rs.GetInt32("Id");
                }
            }
            return accountTypeId;
        }

        public bool accountTypeAssigned(int clientId, int accountTypeId)
        {
            List<Account> accounts = new List<Account>();
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM accounts WHERE ClientId = {clientId} AND AccountType = {accountTypeId}"))
            {
                while (rs.NextRecord())
                {
                    accounts.Add(new Account(rs.GetInt32("Id"),
                        rs.GetInt32("ClientId"),
                        rs.GetInt32("AccountType"),
                        rs.GetDouble("Balance")));
                }
            }
            if (accounts.Count != 0)
            {
                return true;
            }
            return false;
        }

        public void addAccount(Account account)
        {
            ExecuteNonQuery($"INSERT INTO accounts (ClientId, AccountType, Balance) VALUES({account.ClientId}, {account.AccountType}, {account.Balance})");
        }

        public List<ClientAccount> GetClientAccounts()
        {
            List<ClientAccount> clientAccounts = new List<ClientAccount>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT ClientId, LastName, FirstName, accounts.Id, Name, Balance " +
                                                        "FROM ((accounts " +
                                                        "INNER JOIN account_types on account_types.Id = accounts.AccountType) " +
                                                        "INNER JOIN clients ON clients.Id = accounts.ClientId) " +
                                                        "ORDER BY LastName, account_types.Id"))
            {
                while (rs.NextRecord())
                {
                    clientAccounts.Add(new ClientAccount(rs.GetInt32("ClientId"),
                                                         rs.GetString("LastName"),
                                                         rs.GetString("FirstName"),
                                                         rs.GetInt32("Id"),
                                                         rs.GetString("Name"),
                                                         rs.GetDouble("Balance")));
                }
            }
            return clientAccounts;
        }

        public List<ClientAccount> GetClientAccountsByClientId(int clientId)
        {
            List<ClientAccount> clientAccounts = new List<ClientAccount>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT ClientId, LastName, FirstName, accounts.Id, Name, Balance " +
                                                        "FROM ((accounts " +
                                                        "INNER JOIN account_types on account_types.Id = accounts.AccountType) " +
                                                        "INNER JOIN clients ON clients.Id = accounts.ClientId) " +
                                                        $"WHERE clients.Id = {clientId} ORDER BY LastName, account_types.Id"))
            {
                while (rs.NextRecord())
                {
                    clientAccounts.Add(new ClientAccount(rs.GetInt32("ClientId"),
                                                         rs.GetString("LastName"),
                                                         rs.GetString("FirstName"),
                                                         rs.GetInt32("Id"),
                                                         rs.GetString("Name"),
                                                         rs.GetDouble("Balance")));
                }
            }
            return clientAccounts;
        }

        public List<ClientAccount> GetClientAccountsByAccountId(int accountId)
        {
            List<ClientAccount> clientAccounts = new List<ClientAccount>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT ClientId, LastName, FirstName, accounts.Id, Name, Balance " +
                                                        "FROM ((accounts " +
                                                        "INNER JOIN account_types on account_types.Id = accounts.AccountType) " +
                                                        "INNER JOIN clients ON clients.Id = accounts.ClientId) " +
                                                        $"WHERE accounts.Id = {accountId} ORDER BY LastName, account_types.Id"))
            {
                while (rs.NextRecord())
                {
                    clientAccounts.Add(new ClientAccount(rs.GetInt32("ClientId"),
                                                         rs.GetString("LastName"),
                                                         rs.GetString("FirstName"),
                                                         rs.GetInt32("Id"),
                                                         rs.GetString("Name"),
                                                         rs.GetDouble("Balance")));
                }
            }
            return clientAccounts;
        }

        public List<ClientAccount> GetClientAccountsByClientFirstNameOrLastName(string search)
        {
            List<ClientAccount> clientAccounts = new List<ClientAccount>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT ClientId, LastName, FirstName, accounts.Id, Name, Balance " +
                                                        "FROM ((accounts " +
                                                        "INNER JOIN account_types on account_types.Id = accounts.AccountType) " +
                                                        "INNER JOIN clients ON clients.Id = accounts.ClientId) " +
                                                        $"WHERE clients.FirstName LIKE '%{search}%' OR clients.LastName LIKE '%{search}%' ORDER BY LastName, account_types.Id"))
            {
                while (rs.NextRecord())
                {
                    clientAccounts.Add(new ClientAccount(rs.GetInt32("ClientId"),
                                                         rs.GetString("LastName"),
                                                         rs.GetString("FirstName"),
                                                         rs.GetInt32("Id"),
                                                         rs.GetString("Name"),
                                                         rs.GetDouble("Balance")));
                }
            }
            return clientAccounts;
        }

        public List<int> GetAccountsIDs()
        {
            List<int> accountsIds = new List<int>();
            using (SQLiteRecordSet rs = ExecuteQuery("SELECT Id FROM accounts"))
            {
                while (rs.NextRecord())
                {
                    accountsIds.Add(rs.GetInt32("Id"));
                }
            }
            return accountsIds;
        }

        public Account GetAccountById(int accountId)
        {
            Account account = null;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM accounts WHERE Id = {accountId}"))
            {
                while (rs.NextRecord())
                {
                    account = new Account(rs.GetInt32("Id"),
                                          rs.GetInt32("ClientId"),
                                          rs.GetInt32("AccountType"),
                                          rs.GetDouble("Balance"));
                }
            }
            return account;
        }

        public bool isCredit(int accountTypeId)
        {
            bool credit = false;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT Credit FROM account_types WHERE Id = {accountTypeId}"))
            {
                while (rs.NextRecord())
                {
                    credit = bool.Parse(rs.GetString("Credit"));
                }
            }
            return credit;
        }

        public void depositInDebitAccount(int accountId, double amount)
        {
            ExecuteNonQuery($"UPDATE accounts SET Balance = Balance + {amount} WHERE Id = {accountId}");
        }

        public void depositInCreditAccount(int accountId, double amount)
        {
            ExecuteNonQuery($"UPDATE accounts SET Balance = Balance - {amount} WHERE Id = {accountId}");
        }

        public void withdrawInDebitAccount(int accountId, double amount)
        {
            ExecuteNonQuery($"UPDATE accounts SET Balance = Balance - {amount} WHERE Id = {accountId}");
        }

        public bool isLimited(int accountTypeId)
        {
            bool limited = false;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT Limited FROM account_types WHERE Id = {accountTypeId}"))
            {
                while (rs.NextRecord())
                {
                    limited = bool.Parse(rs.GetString("Limited"));
                }
            }
            return limited;
        }

        public AccountType GetAccountTypeById(int accountTypeId)
        {
            AccountType accountType = null;
            using (SQLiteRecordSet rs = ExecuteQuery($"SELECT * FROM account_types WHERE Id = {accountTypeId}"))
            {
                while (rs.NextRecord())
                {
                    accountType = new AccountType(rs.GetInt32("Id"),
                                                    rs.GetString("Name"),
                                                    rs.GetDouble("MonthlyFee"),
                                                    rs.GetDouble("AnnualFee"),
                                                    bool.Parse(rs.GetString("Credit")),
                                                    bool.Parse(rs.GetString("Limited")),
                                                    rs.GetDouble("OverDraftFee"),
                                                    rs.GetDouble("MaxCredit"),
                                                    rs.GetDouble("InteresPct"));
                }
            }
            return accountType;
        }

        public void withdrawInCreditAccount(int accountId, double amount)
        {
            ExecuteNonQuery($"UPDATE accounts SET Balance = Balance + {amount} WHERE Id = {accountId}");
        }

        public void applyOverDraftFee(int accountId, double fee)
        {
            ExecuteNonQuery($"UPDATE accounts SET Balance = Balance + {fee} WHERE Id = {accountId}");
        }

        public void applyMonthlyFee()
        {
            ExecuteNonQuery("UPDATE accounts SET Balance = CASE " +
                            "WHEN AccountType == 0 AND Balance > (SELECT MonthlyFee FROM account_types WHERE Id = 0) THEN Balance - (SELECT MonthlyFee FROM account_types WHERE Id = 0) " +
                            "WHEN AccountType == 0 AND Balance <= (SELECT MonthlyFee FROM account_types WHERE Id = 0) THEN 0 " +
                            "WHEN (AccountType == 1 OR AccountType == 2) AND Balance + (SELECT MonthlyFee FROM account_types WHERE Id = accounts.AccountType) < (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN Balance +(SELECT MonthlyFee FROM account_types WHERE Id = accounts.AccountType) " +
                            "WHEN (AccountType == 1 OR AccountType == 2) AND Balance + (SELECT MonthlyFee FROM account_types WHERE Id = accounts.AccountType) >= (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) " +
                            "WHEN (AccountType == 3 OR AccountType == 4) THEN Balance + (SELECT MonthlyFee FROM account_types WHERE Id = accounts.AccountType) " +
                            "ELSE Balance END");
        }

        public void applyInteresPct()
        {
            // Aplicamos porcentaje de interes
            ExecuteNonQuery("UPDATE accounts SET Balance = CASE " +
                            "WHEN AccountType == 0 AND (Balance - ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) > 0 THEN Balance - ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)" +
                            "WHEN AccountType == 0 AND (Balance - ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) > 0 THEN 0 " +
                            "WHEN (AccountType == 1 OR AccountType == 2) AND (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) < (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) " +
                            "WHEN (AccountType == 1 OR AccountType == 2) AND (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) >= (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) " +
                            "WHEN (AccountType == 3 OR AccountType == 4) AND (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) < (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) " +
                            "WHEN (AccountType == 3 OR AccountType == 4) AND (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance)) >= (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN (Balance + ((SELECT InteresPct FROM account_types WHERE account_types.Id = accounts.AccountType) / 100.0 * Balance) + (SELECT OverDraftFee FROM account_types WHERE Id = accounts.AccountType))" +
                            "ELSE Balance END");
        }

        public void applyAnnualFee()
        {
            ExecuteNonQuery("UPDATE accounts SET Balance = CASE " +
                            "WHEN AccountType == 0 AND Balance > (SELECT AnnualFee FROM account_types WHERE Id = 0) THEN Balance - (SELECT AnnualFee FROM account_types WHERE Id = 0) " +
                            "WHEN AccountType == 0 AND Balance <= (SELECT AnnualFee FROM account_types WHERE Id = 0) THEN 0 " + 
                            "WHEN (AccountType == 1 OR AccountType == 2) AND Balance + (SELECT AnnualFee FROM account_types WHERE Id = accounts.AccountType) < (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN Balance +(SELECT AnnualFee FROM account_types WHERE Id = accounts.AccountType) " + 
                            "WHEN (AccountType == 1 OR AccountType == 2) AND Balance + (SELECT AnnualFee FROM account_types WHERE Id = accounts.AccountType) >= (SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) THEN(SELECT MaxCredit FROM account_types WHERE Id = accounts.AccountType) " +
                            "WHEN (AccountType == 3 OR AccountType == 4) THEN Balance + (SELECT AnnualFee FROM account_types WHERE Id = accounts.AccountType) " +
                            "ELSE Balance END");
        }
    }
}
