import os
import shutil
import datetime

def main():
    src_folder = input("Enter source folder: ")
    dest_folder = input("Enter destination folder: ")
    if not os.path.exists(dest_folder):
        os.makedirs(dest_folder)
    dest_folder = os.path.join(dest_folder, datetime.datetime.now().strftime('%Y%m%d%H%M%S'))
    os.makedirs(dest_folder)
    src_files = os.listdir(src_folder)
    for file_name in src_files:
        full_file_name = os.path.join(src_folder, file_name)
        if os.path.isfile(full_file_name):
            shutil.copy(full_file_name, dest_folder)

if __name__ == "__main__":
    main()