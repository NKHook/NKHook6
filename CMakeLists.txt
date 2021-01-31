cmake_minimum_required(VERSION 3.17)
project(NKHook6 VERSION 0.1.0 LANGUAGES CSharp)

add_subdirectory(References)

add_library(NKHook6 SHARED)

add_subdirectory(NKHook6-Impl)