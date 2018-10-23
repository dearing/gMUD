import { app, BrowserWindow } from 'electron'
import path from 'path'
import format from 'url'

const DEV = process.env.NODE_ENV !== 'production'

app.on('ready', () => {
    let window = new BrowserWindow({
        width: 1024
    })
    if (DEV) {
        window.loadURL(`http://localhost:${process.env.ELECTRON_WEBPACK_WDS_PORT}`)
    } else {
        window.loadURL(format({
            pathname: path.join(__dirname, 'index.html'),
            protocol: 'file',
            slashes: true
        }))
    }
})

