import PubNub from 'pubnub';
var print = log;
print('initialising PubNub');
try {
	var pubnub = new PubNub({
		subscribeKey: 'PUBNUB_SUBSCRIBE_KEY',
		publishKey: 'PUBNUB_PUBLISH_KEY',
		userId: 'jintTest',
		listenToBrowserNetworkEvents: false,
		logVerbosity: true,
	});
} catch (e) {
	var message = JSON.stringify(e);
	print(message);
	print(e.message);
}
const hello = async () => {
	try {
		const result = await pubnub.publish({
			channel: 'jint',
			message: { such: 'object' },
		});
		print(`published ${result.timetoken}`);
	} catch (e) {
		print('publish error');
		print(e.message);
	}
};
hello();
