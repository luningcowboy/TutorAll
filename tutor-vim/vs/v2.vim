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
" vim
