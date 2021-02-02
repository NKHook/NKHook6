cmake_minimum_required(VERSION 3.17)
project(NKHook6 VERSION 0.1.0 LANGUAGES CSharp)

add_library(NKHook6 SHARED)

set_property(TARGET NKHook6 PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.7.1")
set_property(TARGET NKHook6 PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET NKHook6 PROPERTY VS_CONFIGURATION_TYPE ClassLibrary)
set_property(TARGET NKHook6 PROPERTY VS_DOTNET_REFERENCES_COPY_LOCAL OFF)

add_subdirectory(NKHook6-Impl)
add_subdirectory(References)