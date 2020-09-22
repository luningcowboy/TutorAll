#include <stdio.h>
#include <string>
using namespace std;

namespace Diy{
    class Student{
        public:
            string name;
            int age;
            float score;

        public:
            void say(){
                printf("%s age is %d, score is %f\n", name.c_str(), age, score);
            }
    };
}

int main(){
    Diy::Student stu;
    stu.name = "Tom";
    stu.age = 15;
    stu.score = 92.5f;
    stu.say();
    return 0;
}
