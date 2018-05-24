function replacePage(pageUrl) {
	location.replace(pageUrl);
}

function backgroundPage(pageUrl) {
	$.post(pageUrl);
}

function applyPanelId() {
	var panelId = $("#panelId-input-box").val();
	$.post("/app/Settings/storePanelId", {panelId: panelId}, postApplyPanelId);
}

function postApplyPanelId(data) {
	replacePage("/app/Settings/wait?mode=setup");
}

function showInfoPopup() {
	var popup = $("#info-popup");
	var popupBG = $("#info-popup-background");
	popup.fadeIn(400);
	popupBG.fadeIn(400);
}

function hideInfoPopup() {
	var popup = $("#info-popup");
	var popupBG = $("#info-popup-background");
	popup.fadeOut(400);
	popupBG.fadeOut(400);
}

function showWorkerPopup(workerId) {
	$.post("/app/Miner/index", {workerId: workerId}, postGrabWorkerData);
}

function postGrabWorkerData(data) {
	var popup = $("#worker-popup");
	var popupBG = $("#worker-popup-background");
	popup.html(data);
	popup.fadeIn(400);
	popupBG.fadeIn(400);
}

function hideWorkerPopup() {
	var popup = $("#worker-popup");
	var popupBG = $("#worker-popup-background");
	popup.fadeOut(400);
	popupBG.fadeOut(400);
}

function showGPUPopup(gpuInfo) {
	var popup = $("#gpu-popup");
	var popupTextContainer = $("#gpu-popup p");
	var popupBG = $("#gpu-popup-background");
	
	popupTextContainer.html(gpuInfo);
	popup.fadeIn(400);
	popupBG.fadeIn(400);
}

function hideGPUPopup() {
	var popup = $("#gpu-popup");
	var popupBG = $("#gpu-popup-background");
	popup.fadeOut(400);
	popupBG.fadeOut(400);
}