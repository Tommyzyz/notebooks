

/**
 * Warframe.js by Luca Kiebel
 * Contributors:
 * - Tobiah <tobiah@pm.me>
 * Docs and more: https://github.com/WFCD/Warframe.js
 */
const BASE = "https://api.warframestat.us";

class Warframe {
    constructor({ platform = "pc" } = { platform: "pc" }) {
        this.system = platform || "pc"
    }
    get(endpoint, { map, skipPlatform = false } = { skipPlatform: false }) {
        return new Promise((resolve, reject) => fetch(`${BASE}/${skipPlatform ? "" : `${this.system}/`}${endpoint}`)
        .then(d => d.json())
        .then(data => Array.isArray(data) && map ? data.map(map) : data)
        .then(data => resolve(data))
        .catch(e => reject(e)))
    }
    set platform(platform) {
        this.system = platform

    }
    get heartbeat() {
        return this.get("heartbeat", { skipPlatform: true })
    }
    get alerts() {
        return this.get("alerts")
    }
    get sorties() {
        return this.get("sortie")
    }
    get cycleCetus() {
        return this.get("cetusCycle")

    }
    get cycleEarth() {
        return this.get("earthCycle")
    }
    get voidTrader() {
        return this.get("voidTrader")
    }
    get events() {
        return this.get("events")
    }
    get news() {
        return this.get("news")

    }
    get syndicateMissions() {
        return this.get("syndicateMissions")

    }
    get fissures() {
        return this.get("fissures")

    }
    get darkSectors() {
        return this.get("darkSectors")

    }
    get invasions() {
        return this.get("invasions")

    }
    get dailyDeals() {
        return this.get("dailyDeals")

    }
    get simaris() {
        return this.get("simaris")

    }
    get conclaveChallenges() {
        return this.get("conclaveChallenges")

    }
}