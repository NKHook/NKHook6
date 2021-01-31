target_sources(NKHook6 PRIVATE 
    "Entry.cs"
    "Logger.cs"
)
add_subdirectory(Event-Patches)
add_subdirectory(Extensions)
add_subdirectory(Implementations)
add_subdirectory(Properties)