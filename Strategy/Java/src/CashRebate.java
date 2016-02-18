
public class CashRebate extends CashSuper {
	private double moenyRebate;
	
	public CashRebate(String moneyRebate){
		this.moenyRebate = Double.parseDouble(moneyRebate);
	}
	
	public double acceptCash(double money){
		return money * this.moenyRebate;
	}
	
}
