

public class OperationDiv extends Operation{
        public double GetResult() throws Exception{
                if (NumberB == 0) {
                        System.out.println("Divisor cannot be 0");
                        throw new Exception();
                }
                return NumberA / NumberB;
        }
}