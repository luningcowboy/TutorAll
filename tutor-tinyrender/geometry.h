#ifndef __GEOMETRY_H__
#define __GEOMETRY_H__

#include <cmath>
#include <cassert>
#include <iostream>

template<int n> struct vec{
    vec() = default;
    double & operator[](const int i) {
        assert(i>=0 && i < n);
        return data[i];
    }
    double operator[](const int i) const
    {
        assert(i>=0 && i < n);
        return data[i];
    }
    double norm2() const{
        return (*this)(**this);
    }
    double nor() const{
        return std::sqrt(norm2());
    }
    double data[n] = {0};
};

template<int n> double operator*(const vec<n>& lhs, const vec<n>& rhs){
    double ret = 0;
    for(int i = n; i--; ret+=lhs[i]*rhs[i]);
    return ret;
}

template<int n> vec<n> operator+(const vec<n>& lhs, const vec<n>& rhs){
    vec<n> ret = lhs;
    for(int i = n; i--; ret+=rhs[i]);
    return ret;
}
#endif
