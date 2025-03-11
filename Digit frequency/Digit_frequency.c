#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main() {
    char arr[1000];
    int count[10] = {0};  
    int i = 0;
    scanf("%s", arr);

    // Traverse the string
    while (arr[i] != '\0') {
        if (isdigit(arr[i])) {
            count[arr[i] - '0']++;  
        }
        i++;
    }

    for (int j = 0; j < 10; j++) {
        printf("%d ", count[j]);
    }
    printf("\n");  

    return 0;
}
