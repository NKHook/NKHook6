# Set cmake version & make project
cmake_minimum_required(VERSION 3.17)
project(NKHook6 VERSION 0.1.0 LANGUAGES CSharp)

# Create .dll
add_library(NKHook6 SHARED)

# Set the C# language version to 9
set_target_properties(NKHook6 PROPERTIES VS_GLOBAL_LangVersion "9.0")

# Set project properties
set_property(TARGET NKHook6 PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8")
set_property(TARGET NKHook6 PROPERTY WIN32_EXECUTABLE FALSE)
set_property(TARGET NKHook6 PROPERTY VS_CONFIGURATION_TYPE ClassLibrary)
set_property(TARGET NKHook6 PROPERTY VS_DOTNET_REFERENCES_COPY_LOCAL OFF)

# Add sources
add_subdirectory(NKHook6-Impl)
add_subdirectory(References)