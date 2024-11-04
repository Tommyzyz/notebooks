#include <stdio.h>

int result = 0;
void pr() 
{
    printf("Hello, world!\n");
}


int main() 
{
    for (int i = 0; i < 5; i++)
    {
        printf("%d\n", i);
        pr();
    }
    scanf("%d", &result);
    
    printf("RESULT: %d\n", result);

    return 0;
}