using Nerdbank.Bitcoin;
using Nerdbank.Zcash;

namespace AvaloniaApplication1.ViewModels;

public class MainViewModel : ViewModelBase
{
	public string Greeting { get; }

	public MainViewModel()
	{
		ZcashAccount account = new(new Zip32HDWallet(Bip39Mnemonic.Create(256), ZcashNetwork.TestNet));
		this.Greeting = $"Welcome to Avalonia: {account.DefaultAddress}";
	}
}
