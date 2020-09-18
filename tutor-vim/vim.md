每个文件都是一个缓冲区
查看缓冲区列表`:ls`

打开文件:
`:e file-name`

## 文件跳转:
1. `:b 缓冲区编号` 中间的空格可以省略,比如跳转到第1个文件:`:b1`
2. 通过文件名跳转: `:b 文件名`
可以使用tab补全名称
3. 可以使用`:bn (:bnext)`和`:bp (:bprevious) `遍历缓冲区
4. `:bd` 将当前文件从缓冲区列表中删除，同时退出这个文件, 但不会关闭vim

## [插件]vim-unimpaired
- ]b [b 循环遍历

`:split file-name` 水平分割窗口，新窗口显示一个新文件
`:split` 水平分割窗口
`:sp`用来简化上面的命令

`:vsplit file-name` 垂直分割窗口
`:vs` 是`:vsplit`的简写

`ctrl+ww`窗口切换
`ctlr+wh/j/k/l`窗口切换
`ctrl+wq` 关闭当前窗口
`:qa` 关闭所有窗口
`:wqa` 关闭所有窗口并保存

窗口移动:
`ctrl+w,H/J/K/L`

`ctrl+w,r/R` 同一行的窗口
`ctrl+w,x` 当前窗口与下一个窗口的内容交换
