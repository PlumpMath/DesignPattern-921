import java.lang.*;

public class Simple_Factory{
        public static void main(String args[]){
                Operation oper = OperationFactory.createOperation("/");
                oper.setNumberA(1.3);
                oper.setNumberB(0);
                try {
					System.out.println("Result is " + oper.GetResult());
				} catch (Exception e) {
					// TODO Auto-generated catch block
					System.out.println("Please input the divisor and dividend again");
				}
        }
}
