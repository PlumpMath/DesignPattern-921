
public class Strategy {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		double total = 0;
		CashContextFactory csf = new CashContextFactory("80% discount");
		double totalPrices = csf.GetResult(288 * 3);
		System.out.println("Result: " + totalPrices);
	}

}
