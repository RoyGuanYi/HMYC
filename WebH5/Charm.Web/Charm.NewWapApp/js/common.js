/*==========================
 * 刷新父窗口
 * @param
 * @return
 */
function RefreshParentWindow() {
    if (window.parent && window.parent != window) {
        window.parent.location.reload();
    } else {
        window.location.reload();
    }
    //window.location.reload(true); // 设为true强制从服务器加载，避免firefox的重复post
}