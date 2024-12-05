# Quantifing Animal behavior Work ....
## Download example data, clips and external packages:

[Download: Shared OneDrive Folder](https://neurogears-my.sharepoint.com/:f:/g/personal/t_ryan_neurogears_org/EokFwZYwH_xNvsJVq05I4wgBOxHhyaGkTTZiAKRU6gzrSA?e=Wq4vSY)

Inside you will find a `Data` folder and an `ExternalPackages` folder containing the CuDNN archive. Copy the entire `data` folder from the OneDrive to the root of the repository. (".\quantifying-animal-behavior\data"). You can ignore the external packages until later...

## Install instructions 
### Visual Studio Community (optional)

1. Download and run [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/).
2. Check .NET Desktop Development workload
3. (optional) uncheck IntelliCode support.

Launch Visual Studio, and set some options up:

Navigate to `TOOLS->Options->Debugging->General` and disable "Require source files to exactly match the original version" .

Go to `TOOLS->Options->Debugging->Symbols` and enable the Microsoft Symbols Server.
Finally, under `TOOLS->Options->Debugging`, check "Enable Just My Code' and "use Manage/Unmanage mode".

## Bonsai 
- Open the `.bonsai` folder 
- run `setup.cmd`

- This will download and create a local Bonsai installation that you can use to edit and run the Workflows in this project

## Install external SLEAP dependencies (Optional)
> **NOTE:**  This step is optional for hardware acceleration IF you have a compatible NVidia card. If not, or for slow but less painful install, skip this and download the [CPU version of tensorflow](#install-tensorflow-21). 

([Full instructions](https://bonsai-rx.org/sleap/index.html), but we shouldn't need this!)

In order to use the graphics card for hardware accelerated inference in Bonsai, you will need to install the [Cuda Toolkit 11.3](https://developer.nvidia.com/cuda-11.3.0-download-archive) (for SLEAP multi-animal tracking)
   * Select Custom install and check `CUDA > Development` and `CUDA > Runtime` ONLY (uncheck everything else)
 
Now download [cuDNN 8.2.1](https://developer.nvidia.com/cudnn)

You will need to login to the NVidia website to download cuDNN. But you can also download it from the "External Packages" folder [shared OneDrive folder](https://neurogears-my.sharepoint.com/:f:/g/personal/t_ryan_neurogears_org/EokFwZYwH_xNvsJVq05I4wgBOxHhyaGkTTZiAKRU6gzrSA?e=Wq4vSY) if you have issues

Once installed, could be worth checking your User and System Variables. You should see your python installation on the `Path` of User Variables. It should look something like this:

![Path](./assets/path.png)

You should see the CUDA_PATH is correctly pointing to CUDA 11.3

If you double click on the path in user variables, you will see a list of paths. You should find your Python 3.10 installation here

![Env](./assets/envvar.png)

And double click the Path under System variables:
![SysEnv](./assets/envpath.png)
### Install tensorflow 2.1
<u>Windows Binaries:</u>

[Windows download, CPU:](https://storage.googleapis.com/tensorflow/versions/2.18.0/libtensorflow-cpu-windows-x86_64.zip)

[Windows download, GPU:](https://storage.googleapis.com/tensorflow/libtensorflow/libtensorflow-gpu-windows-x86_64-2.10.0.zip)

### Set up python environment for Bonsai.ML
#### 1. <u>(Recommended)</u> Visual Studio Code
[Direct Download: python 3.10 (Windows 64-bit installer)](https://www.python.org/ftp/python/3.10.0/python-3.10.0-amd64.exe) 
[Python release page](https://www.python.org/downloads/release/python-3100/)

Hit Ctrl-P to bring up the command pallette. Choose `Python: Create Environment...`, then `Venv`.
Choose your Python 3.10 installation as the interpreter path, and check the `requirements.txt`.

Done. If you now open a new Powershell terminal, the environment will activate automatically.

#### 2. (Optional) From a command line terminal:

Install virtual env if needed
```bash
pip install virtualenv
```

Create the virtual environment and activate it
```bash
python -m venv .venv
.venv\Scripts\activate
```

```bash 
pip install -r requirements.txt
```
### Run Bonsai from the command line terminal:

```bash
.\.bonsai\Bonsai.exe
```

### Open the workflows!