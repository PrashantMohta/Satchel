import os
# os.chdir('/Users/epicm/PycharmProjects/HKTranslationnScript/EN/translated/Backup')

for fn in os.listdir():
   if fn == '.DS_Store':
        continue
   file_name, file_ext = os.path.splitext(fn)
   if file_ext == ".cs":
        os.remove(fn)

for fn in os.listdir():
    if fn == '.DS_Store':
        continue

    file_name, file_ext = os.path.splitext(fn)
    if file_ext == '.py': continue

    new_name = f"{file_name}.cs"

    os.rename(fn, new_name)

input("Done")