BEGIN {
print "Users and their age" 
print "User \t Age"
FS=","
}
{ 
print $1 " \t " $3
}
END {
print "There are three people" 
}
