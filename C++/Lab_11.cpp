#include <iostream>
using namespace std;
class point {
public:
    int x; int y;
};

int main()
{
    const int LENGHT = 3;
    point* arr1 = new point[LENGHT];
    cout << "Odnomerny array Size = " << LENGHT << ":\n";
    for (int i = 0; i < LENGHT; i++)
    {
        arr1[i].x = i;
        arr1[i].y = i + i;
    }
    for (int i = 0; i < LENGHT; i++)
    {
        cout << "X = " << arr1[i].x << "\t";
        cout << "Y = " << arr1[i].y << endl;
    }

    delete[] arr1;
   
    point arr2[LENGHT][LENGHT];
    cout << "Dvymerniy array Size = " << LENGHT <<"x"<< LENGHT << ":\n";
    for (int i = 0; i < LENGHT; i++)
    {
        for (int q = 0; q < LENGHT; q++)
        {
            arr2[q][i].x = i+q;
            arr2[q][i].y = i + i + q + q;
        }
    }

    for (int i = 0; i < LENGHT; i++)
    {
        for (int q = 0; q < LENGHT; q++)
        {
            cout << "X = " << arr2[q][i].x << "\t";
            cout << "Y = " << arr2[q][i].y << endl;
        }
    }
}
