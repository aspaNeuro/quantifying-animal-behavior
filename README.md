# Quantifying Animal Behaviour
## Download example data, clips and external packages:

[Download: Shared OneDrive Folder](https://neurogears-my.sharepoint.com/:f:/g/personal/t_ryan_neurogears_org/EokFwZYwH_xNvsJVq05I4wgBOxHhyaGkTTZiAKRU6gzrSA?e=Wq4vSY)

Inside you will find a `Data` folder and an `ExternalPackages` folder containing the cudnn and tensorflow packages. Copy the entire `data` folder from the OneDrive to the root of the repository. (".\quantifying-animal-behavior\data"). You'll need the packages later

## <u>Install instructions</u>  
## Bonsai
- Open the `.bonsai` folder and run `setup.cmd`

This will run the powershell script `setup.ps1` to automatically intall a local Bonsai installation you can use to edit and run the Workflows in this project
---
## Install third party SLEAP dependencies (Optional)
> **NOTE:**  This step is optional for hardware acceleration IF you have a compatible NVidia card. If not, or for slow workflow but easier install, skip this bit.

([Full instructions](https://bonsai-rx.org/sleap/index.html), but we shouldn't need this!)

In order to use the graphics card for hardware accelerated inference in Bonsai, you will need to install the [Cuda Toolkit 11.3](https://developer.nvidia.com/cuda-11.3.0-download-archive) (for SLEAP multi-animal tracking)
   * Select Custom install and check `CUDA > Development` and `CUDA > Runtime` ONLY (uncheck everything else)

You will also need the cuDNN and tensorflow packages. You can find these in the "External Packages" folder [shared OneDrive folder](https://neurogears-my.sharepoint.com/:f:/g/personal/t_ryan_neurogears_org/EokFwZYwH_xNvsJVq05I4wgBOxHhyaGkTTZiAKRU6gzrSA?e=Wq4vSY). 

Once installed, could be worth checking your User and System Variables. You should see your Python 3.10 installation on the path of User Variables. You should see the CUDA_PATH is correctly pointing to CUDA 11.3, and the Cuda/bin folder is on the system variables path.
---
### Set up python environment for Bonsai.ML
#### 1. <u>(Recommended)</u> Visual Studio Code
[Direct Download: python 3.10 (Windows 64-bit installer)](https://www.python.org/ftp/python/3.10.0/python-3.10.0-amd64.exe) 
[Python release page](https://www.python.org/downloads/release/python-3100/)

Hit Ctrl-P to bring up the command pallette. Choose `Python: Create Environment...`, then `Venv`.
Choose your **Python 3.10** installation as the interpreter path, and check the `requirements.txt`.

Done. If you now open a new Powershell terminal, the environment will activate automatically.

#### 2. (Optional) From a command line terminal:

Install virtual env if needed
```bash
pip install virtualenv
```
Create the virtual environment
```bash
python -m venv .venv
.venv\Scripts\activate
pip install -r requirements.txt
```

## Clone BonFly

We will also clone the BonFly repository.

```
git clone https://github.com/jfrazao/BonFly.git
```

Install Bonsai by running the `setup.cmd` as before

### Run Bonsai from the command line terminal:

```bash
.\.bonsai\Bonsai.exe
```

### Open the workflows!
---

#### P.S. 
#### Visual Studio Community (optional)

1. Download and run [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/).
2. Check .NET Desktop Development workload
3. (optional) uncheck IntelliCode support.

Launch Visual Studio, and set some options up:

Navigate to `TOOLS->Options->Debugging->General` and disable "Require source files to exactly match the original version" .

Go to `TOOLS->Options->Debugging->Symbols` and enable the Microsoft Symbols Server.
Finally, under `TOOLS->Options->Debugging`, check "Enable Just My Code' and "use Manage/Unmanage mode".

### Troubleshooting Cuda and Python path.

![Path](./assets/path.png)

![Env](./assets/envvar.png)

![SysEnv](./assets/envpath.png)
