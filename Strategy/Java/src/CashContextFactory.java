
public class CashContextFactory {
	private CashSuper cs = null;
	public CashContextFactory(String type){
		if (type == "Normal"){
			cs = new CashNormal();
		}
		else if (type == "80% discount"){
			cs = new CashRebate("0.8");
		}
	}
	
	public double GetResult(double money){
		return cs.acceptCash(money);
	}
}
