using System.Transactions;
namespace walletinout.Repositories;

public interface  IWalletRepository
{
    List<Transaction> GetTransactions();
}
public class WalletRepository
{
    private readonly IConfiguration _configuration;

    public WalletRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }
}