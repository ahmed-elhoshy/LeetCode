#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.


void calculate_the_maximum(int n, int k) {
int max_and=0,max_or=0,max_xor=0;

for(int a=1;a<n;a++)
{
    for(int b=a+1;b<=n;b++)
    {
        int and_result=a&b;
        int or_result=a|b;
        int xor_result=a^b;
        if(and_result > max_and && and_result < k)
        {
            max_and =and_result;
        }
        if(or_result > max_or && or_result < k)
        {
            max_or =or_result;
        }
        if(xor_result > max_xor && xor_result < k)
        {
            max_xor =xor_result;
        }
    }
}
printf("%d\n",max_and);
printf("%d\n",max_or);
printf("%d\n",max_xor);

}

int main() {
    int n, k;
  
    scanf("%d %d", &n, &k);
    calculate_the_maximum(n, k);
 
    return 0;
}
