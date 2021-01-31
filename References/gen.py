import os
for filename in os.listdir():
    if(filename.endswith(".dll")):
        goodName = filename.replace(".dll", "");
        print("""set_property(TARGET NKHook6 PROPERTY VS_DOTNET_REFERENCES_"""+goodName+""" "${CMAKE_CURRENT_LIST_DIR}/"""+goodName+""".dll")""")