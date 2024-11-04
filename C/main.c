#include <stdio.h>
int result = 0;
int main() {
    for (int i = 0; i < 10; i++)
    {
        printf("%d\n", i);
    }
    scanf("%d", &result);
    
    printf("Hello, world!1\n");
    printf("%d\n", result);
    printf("Hello, world!2\n");
    return 0;
}