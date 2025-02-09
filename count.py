import os

def count_lines_of_code(directory, extensions=None, comment_symbols=None):
    if extensions is None:
        extensions = {".py", ".js", ".ts", ".java", ".cpp", ".c", ".cs", ".php", ".html", ".css", ".dart"}
    if comment_symbols is None:
        comment_symbols = {".py": "#", ".js": "//", ".ts": "//", ".java": "//", ".cpp": "//", ".c": "//", ".cs": "//", ".php": "//", ".html": "<!--", ".css": "/*", ".dart": "//"}
    
    total_lines = 0
    for root, _, files in os.walk(directory):
        for file in files:
            ext = os.path.splitext(file)[1]
            if ext in extensions:
                file_path = os.path.join(root, file)
                with open(file_path, "r", encoding="utf-8", errors="ignore") as f:
                    lines = f.readlines()
                    
                    # Remove empty lines and comment lines
                    symbol = comment_symbols.get(ext, "#")
                    valid_lines = [line for line in lines if line.strip() and not line.strip().startswith(symbol)]
                    
                    total_lines += len(valid_lines)
    
    return total_lines

if __name__ == "__main__":
    repo_path = input("Enter the repository path: ")
    loc = count_lines_of_code(repo_path)
    print(f"Total lines of code: {loc}")
