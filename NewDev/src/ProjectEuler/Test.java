package ProjectEuler;
 
public class Test { 
	public static void main(String[] args) {
//		Scanner test = new Scanner(System.in);
//		double asdf;
//		asdf =  test.nextDouble();
//		System.out.println(asdf);  
		int sum = 0;
		int[] arr = new int[400];
		arr[0] = 1;
		int carry = 0;
		
		for (int i = 0 ;i<1000;i++)
		{ 
			for (int j = 0 ;j <arr.length;j++)
			{ 
				int temp  = arr[j] *2;
				if(temp >9)
				{
					arr[j] = (temp % 10)+carry;
					carry =1; 
				}
				else {
					arr[j] = temp+carry;
					carry =0; 
				}
			}
		}
		
		for (int i = 0;i<arr.length;i++)
		{
			sum +=arr[i]; 
		}
		System.out.println(sum);
	} 
}