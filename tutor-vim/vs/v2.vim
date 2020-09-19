if has('win32')
    echo 'win32'
else
    echo 'other'
endif

" vimscript没有布尔值，1为真,0为假
let is_cat = 1
if is_cat
    echo 'is_cat = 1'
else
    echo 'is_cat = 0'
endif

" 作用域
" 通过变量的前缀实现
" let g:animal_name = "xxxx"
" let w:is_cat = 1
" g: 全局变量
" v: vim定义的全局变量
" l: 局部作用于变量
" b: 当前缓冲区
" w: 当前窗口
" t: 表示当前页签
" s: 表示水涌:source'd执行的vim脚本文件中的局部作用域
" a: 表示函数的参数
" 在寄存器中保存
" 在寄存器a中保存
" let @a = 'cats are weird'
" vim选项(使用set修改的那些变量)
" let &ignorecase = 0
" 整数相加用+,-,*,/
" 字符串拼接用.
let g:animal_name = 'Mary'
let g:cat_statment = g:animal_name . ' is ''a'' cat'
" 输出单引号可以使用两个单引号
echo g:cat_statment
" 输出用echo:不能被记录
" 使用echomsg(echom)输出的内容会被记录,可以使用:messages命令查看
echom 'Test echom'
" 显示count个最近的消息:{count}messages
" 清楚消息:messages clear

" 条件表达式
let g:animal_kind = 'cat'
if g:animal_kind == 'cat'
    echo g:animal_name . ' is a cat'
elseif g:animal_kind == 'dog'
    echo g:animal_name . ' is a dog'
else
    echo g:animal_name . ' is something else'
endif

" 三目运算
echo g:animal_name . (g:is_cat ? ' is a cat' : ' is something else')

" 逻辑运算符
" 与&&
" 或||
" 非!

if !(is_cat || g:is_dog)
    echo g:animal_name . ' is a cat'
endif

" 比较运算符
" == 比较两个字符串，是否忽略大小写取决于用户设置
" ==?比较两个字符串，忽略大小写
" ==#比较两个字符串，考虑大小写
" =~表示使左操作数与右操作数匹配
" =~?考虑大小写
" =~#忽略大小写
" !=与~=相反
