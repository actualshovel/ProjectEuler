package programByDoing;

public class Problem003 {

	public static void main(String[] args) {
		long a = 600851475143L;
		int factor = 0, factor2 = 0;
		
		while (a % 2 == 0) {
			System.out.println(2  + " ");
			a /= 2;
		}
		
		for (int i = 3; i <= Math.sqrt(a); i+= 2) {
			while (a % i == 0 ) {
				System.out.println(i + " ");
				a /= i;
				
				if (i >= factor)
					factor = i;
			}
		}
		
		if ( a > 2 ) {
			System.out.println(a);
			if (factor > a )
				System.out.println(factor + " is the largest prime facto.");
			else
				System.out.println(a + " is the largest prime factor.");
		}	
	}

}
